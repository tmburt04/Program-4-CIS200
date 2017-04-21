// Program 4
// CIS 200-01
// Due: 4/19/2017
// By: D4574

// File: ExtracreditSort.cs
// Description: This file sorts items by Type and then by Title ASC

using System;
using System.Collections.Generic;

namespace LibraryItems
{
    class EC_Sort : IComparer<LibraryItem>
    {
        public int Compare(LibraryItem LibraryItem1, LibraryItem LibraryItem2)
        {
            // Tests whether both items are null
            if (LibraryItem1 == null && LibraryItem2 == null) 
            {
                return 0;
            }

            // Tests whether the first item is null
            if (LibraryItem1 == null)
            {
                return -1;
            }

            // Tests whether the second item is null
            if (LibraryItem1 == null)
            {
                return 1;
            }

            // Tests whether the two items have the same type
            int sameType = string.Compare(LibraryItem1.GetType().ToString(), LibraryItem2.GetType().ToString());

            if (sameType != 0)
            {
                return sameType;
            }
            else
            {
                // tests whether the two items have the same title
                if (LibraryItem1.Title.CompareTo(LibraryItem2.Title) != 0)
                {
                    return LibraryItem1.Title.CompareTo(LibraryItem2.Title);
                }
                // tests whether the two items have the same publisher
                else if (LibraryItem1.Publisher.CompareTo(LibraryItem2.Publisher) != 0)
                {
                    return LibraryItem1.Publisher.CompareTo(LibraryItem2.Publisher);
                }
                // tests whether the two items have the same copyright year
                else
                {
                    return LibraryItem1.CopyrightYear.CompareTo(LibraryItem2.CopyrightYear);
                }
            }
        }
    }
}
