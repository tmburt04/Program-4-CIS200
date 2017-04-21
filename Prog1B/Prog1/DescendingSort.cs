// Program 4
// CIS 200-01
// Due: 4/19/2017
// By: D4574

// File: DescendingSort.cs
// Description: This file sorts items by Copyright Year in DESC order

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class DescendingSort : IComparer<LibraryItem>
    {
        //Precondition: None
        //Postcondition: Reverse the order of Copyright Year so its DESC
        public int Compare(LibraryItem LibraryItem1, LibraryItem LibraryItem2)
        {
            // tests whether both values are null
            if (LibraryItem1 == null && LibraryItem2 == null)
            {
                return 0;
            }

            // tests whether the first LibaryItem is Null
            if (LibraryItem1 == null)
            {
                return -1;
            }

            // tests whether the second LibaryItem is Null
            if (LibraryItem1 == null)
            {
                return 1;
            }

            //Tests whether copyright years are the same
            if (LibraryItem1.CopyrightYear.CompareTo(LibraryItem2.CopyrightYear) != 0)
            {
                return LibraryItem1.CopyrightYear.CompareTo(LibraryItem2.CopyrightYear);
            }
            //Tests whether the titles are the same
            else if (LibraryItem1.Title.CompareTo(LibraryItem2.Title) != 0)
            {
                return LibraryItem1.Title.CompareTo(LibraryItem2.Title);
            }
            //Tests whether the publishers are the same
            else
            {
                return LibraryItem1.Publisher.CompareTo(LibraryItem2.Publisher);
            }
        }
    }
}
