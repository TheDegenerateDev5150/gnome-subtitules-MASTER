/*
 * This file is part of SubLib.
 * Copyright (C) 2006-2009 Pedro Castro
 *
 * SubLib is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * SubLib is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
 */

using System;

namespace SubLib.IO.Output {

internal class VerboseConsole {
	private static bool verbose = false;
	
	internal static bool Verbose {
		get { return verbose; }
		set { verbose = value; }	
	}
	
	internal static void Write (string text) {
		if (verbose)
			Console.Error.Write(text);
	}
	
	internal static void WriteLine (string text) {
		if (verbose)
			Console.Error.WriteLine(text);
	}

}

}
