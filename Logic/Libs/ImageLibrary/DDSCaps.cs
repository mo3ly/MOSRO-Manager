/*
 *  Copyright 2012 Tamme Schichler <tammeschichler@googlemail.com>
 * 
 *  This file is part of TQ.Texture.
 *
 *  TQ.Texture is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  TQ.Texture is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with TQ.Texture.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace MediaExtractorLibrary.GDImageLibrary
{
    [Flags]
    public enum DDSCaps
    {
        Complex = 0x8,
        Mipmap = 0x400000,
        Texture = 0x1000
    }
}