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
