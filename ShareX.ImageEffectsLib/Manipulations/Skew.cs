﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2023 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using System.ComponentModel;
using System.Drawing;

namespace ShareX.ImageEffectsLib
{
    internal class Skew : ImageEffect
    {
        [DefaultValue(0), Description("How much pixel skew left to right.")]
        public int Horizontally { get; set; }

        [DefaultValue(0), Description("How much pixel skew top to bottom.")]
        public int Vertically { get; set; }

        public Skew()
        {
            this.ApplyDefaultPropertyValues();
        }

        public override Bitmap Apply(Bitmap bmp)
        {
            if (Horizontally == 0 && Vertically == 0)
            {
                return bmp;
            }

            return ImageHelpers.AddSkew(bmp, Horizontally, Vertically);
        }

        protected override string GetSummary()
        {
            return $"{Horizontally}px, {Vertically}px";
        }
    }
}