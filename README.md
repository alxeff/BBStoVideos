# BBStoVideos

A WinForms utility that works with a BBS folder and a video folder. It can:

- delete `*.log` files from the BBS folder
- move `*.mp4` files from the BBS folder into the video folder
- renumber the video folder's `*.mp4` files as `1.mp4, 2.mp4, 3.mp4…` in recording order

## Requirements

The .NET 10 SDK with the Windows Desktop workload.

## Build and run

```powershell
cd BBStoVideos
dotnet build
dotnet run
```

## How to use

1. Click **BBS Folder** and pick the folder holding your `.log` and `.mp4` files.
2. Click **Video Folder** and pick where the videos should go.
3. Run an action:
   - **Delete .txt's** — actually deletes `*.log` files
   - **Move to videos folder** — moves `*.mp4` files across
   - **Sort** — renames the video folder's `*.mp4` files to `1.mp4, 2.mp4, 3.mp4…`

Note: all three actions work on the top level of the chosen folder only; they do
not recurse into subfolders.

## Publishing to GitHub

Push **this folder** (`bbsTovideos`) as its own repository. Do not push the
parent `aliks` folder — it contains a `bottoken.txt` and large unrelated files.

1. Install Git if you do not have it: `winget install --id Git.Git -e`, then
   restart the terminal.
2. Create an **empty** repository on GitHub (no README, no .gitignore, no
   license — otherwise the first push conflicts).
3. From this folder:

```powershell
git init
git add .
git status          # should list the 11 files below
git commit -m "Initial commit: BBStoVideos"
git branch -M main
git remote add origin https://github.com/<you>/BBStoVideos.git
git push -u origin main
```

`git status` should show exactly these 11 files and nothing else:

```
.gitignore
BBStoVideos.slnx
BBStoVideos/BBStoVideos.csproj
BBStoVideos/Form1.cs
BBStoVideos/Form1.Designer.cs
BBStoVideos/Form1.resx
BBStoVideos/Program.cs
BBStoVideos/Properties/Resources.Designer.cs
BBStoVideos/Properties/Resources.resx
LICENSE
README.md
```

If you see any `bin/`, `obj/`, `.vs/` or `*.csproj.user` entries, the
`.gitignore` is not being picked up — do not commit until that is fixed.
`BBStoVideos.csproj.user` in particular stores local machine paths.

Note: `Form1.resx` is about 1 MB because it contains an embedded image. That is
expected.

If you ever do commit a secret, deleting the file is not enough — it stays in
the history and in every clone. Rotate the credential and rewrite history with
`git filter-repo` before pushing.

## License

Copyright (C) 2026 Aliks

This program is free software: you can redistribute it and/or modify it under
the terms of the **GNU General Public License, version 3** as published by the
Free Software Foundation, either version 3 of the License, or (at your option)
any later version.

This program is distributed in the hope that it will be useful, but
**WITHOUT ANY WARRANTY**; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General
Public License for more details.

You should have received a copy of the GNU General Public License along with
this program. If not, see <https://www.gnu.org/licenses/>. The full text is in
[`LICENSE`](LICENSE).

GPL-3.0 is a **copyleft** license: anyone may use, modify and redistribute this
program, including commercially, but if they *distribute* a modified version
they must release their version under GPL-3.0 as well and make its source
available. They cannot turn a derivative into a closed-source product. Simply
using the program privately carries no obligations.

## Design notes

This file logic is kept directly in the form's click handlers
(`Form1.cs`). Some known rough edges:

- the two folder paths are not validated before an action runs
- the sort action calls `File.Move` without an overwrite flag, so re-running it
  on a folder that already contains `1.mp4` will fail partway through
- a single locked or read-only file aborts the rest of the batch
- the button labelled "Delete .txt's" deletes `*.log` files, not `*.txt`
