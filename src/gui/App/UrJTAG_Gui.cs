/*
  Copyright© (c) 2017-2018 S.Gray, (aka PiezPiedPy).

  This file is part of UrJTAG-VSharp.
  UrJTAG-VSharp is available under the terms of GPL-3.0-or-later.
  See the LICENSE.md file for more details.

  UrJTAG-VSharp is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  UrJTAG-VSharp is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

  You should have received a copy of the GNU General Public License
  along with UrJTAG-VSharp.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrJTAG_Gui
{
  static class UrJTAG_Gui
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
