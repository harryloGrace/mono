//
// System.Windows.Forms.ColumnClickEventArgs
//
// Author:
//   stubbed out by Jaak Simm (jaaksimm@firm.ee)
//   Implmented by Dennis Hayes <dennish@raytek.com>
//
// (C) Ximian, Inc., 2002
//

namespace System.Windows.Forms
{
	/// <summary>
	/// Provides data for the ColumnClick event.
	/// </summary>
	public class ColumnClickEventArgs : EventArgs
	{
		private int column;
		/// --- Constructor ---
		protected ColumnClickEventArgs(int Column) : base() {
			column = Column;
		}
		
		
		/// --- Properties ---
		public int Column {
			get { 
				return column;
			}
		}

		// add. remove comment after modifing for this class
		/// <summary>
		///	Equality Operator
		/// </summary>
		///
		/// <remarks>
		///	Compares two ColumnClickEventArgs objects. The return value is
		///	based on the equivalence of the Column properties 
		///	of the two ColumnClickEventArgs.
		/// </remarks>

		public static bool operator == (ColumnClickEventArgs ColumnClickEventArgsA , ColumnClickEventArgs ColumnClickEventArgsB) {
			return ColumnClickEventArgsA.column == ColumnClickEventArgsB.column;
		}
		
		/// <summary>
		///	Inequality Operator
		/// </summary>
		///
		/// <remarks>
		///	Compares two ColumnClickEventArgs objects. The return value is
		///	based on the equivalence of the Column properties 
		///	of the two ColumnClickEventArgs.
		/// </remarks>

		public static bool operator != (ColumnClickEventArgs ColumnClickEventArgsA, ColumnClickEventArgs ColumnClickEventArgsB) {
			return ColumnClickEventArgsA.column != ColumnClickEventArgsB.column;
		}
		/// <summary>
		///	Equals Method
		/// </summary>
		///
		/// <remarks>
		///	Checks equivalence of this ColumnClickEventArgs and another object.
		/// </remarks>
		
		public override bool Equals (object o) {
			if (!(o is ColumnClickEventArgs))return false;
			return (this == (ColumnClickEventArgs) o);
		}


		/// <summary>
		///	GetHashCode Method
		/// </summary>
		///
		/// <remarks>
		///	Calculates a hashing value.
		/// </remarks>
		// If class has only one proprity, just return the hash code of the proprity.
		public override int GetHashCode () {
			return column.GetHashCode();
		}

		/// <summary>
		///	ToString Method
		/// </summary>
		///
		/// <remarks>
		///	Formats the ColumnClickEventArgs as a string.
		/// </remarks>
		
		public override string ToString () {
			return String.Format ("[{0}]", column);
		}
  
		//end add. remove comment after modifing for this class

	}
}
