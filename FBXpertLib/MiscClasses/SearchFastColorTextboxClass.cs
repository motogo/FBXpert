using FastColoredTextBoxNS;
using System.Collections.Generic;
using System.Drawing;

namespace FBXpertLib
{
    public class SearchListItem
    {
        public int pos;
        public int length;
        public string text;
    }
    public class SearchFastColorTextboxClass
    {
        public bool caseSensitivity = false;
        public bool wholeWord = false;
        private FastColoredTextBox fctInfo;
        private int searchListInx = -1;
        private int searchInx = -1;
        private int searchInxOld = 0;
        private bool doNewSearch = true;
        private string searchPattern = string.Empty;
        private List<SearchListItem> searchList;
        private List<int> bookmarkList;
        private Color bookmarkColor = Color.Blue;
        private int actItemInx = -1;
        public SearchFastColorTextboxClass(FastColoredTextBox fct)
        {
            fctInfo = fct;
        }

        public Color BookmarkColor
        {
            set => bookmarkColor = value;
            get => bookmarkColor;
        }

        public bool CaseSensitivity
        {
            set => caseSensitivity = value;
            get => caseSensitivity;
        }

        public int ActualItemIndex
        {
            get => actItemInx;
        }
        public int FoundCount
        {
            get => searchList == null ? 0 : searchList.Count;
        }

        public bool WholeWord
        {
            set => wholeWord = value;
            get => wholeWord;
        }
        public string SearchPattern
        {
            set => searchPattern = value;
            get => searchPattern;
        }

        public void NewSearchPattern(string searchp)
        {
            SearchPattern = searchp;
            doNewSearch = true;
        }

        public void BookmarkAll()
        {
            fctInfo.BookmarkColor = bookmarkColor;
            UnBookmarkAll();
            foreach (int pos in bookmarkList)
            {
                fctInfo.BookmarkLine(pos);
            }
        }
        public void UnBookmarkAll()
        {
            for (int i = 0; i < fctInfo.LinesCount; i++)
            {
                fctInfo.UnbookmarkLine(i);
            }
        }

        public int GetLowestInx(string subs)
        {
            List<int> inx = new List<int>();
            int searchInx1 = (caseSensitivity) ? subs.IndexOf($@" {SearchPattern} ") : subs.ToLower().IndexOf($@" {SearchPattern} ".ToLower());
            int searchInx2 = (caseSensitivity) ? subs.IndexOf($@" {SearchPattern},") : subs.ToLower().IndexOf($@" {SearchPattern},".ToLower());
            int searchInx3 = (caseSensitivity) ? subs.IndexOf($@" {SearchPattern}.") : subs.ToLower().IndexOf($@" {SearchPattern}.".ToLower());
            int searchInx4 = (caseSensitivity) ? subs.IndexOf($@",{SearchPattern} ") : subs.ToLower().IndexOf($@",{SearchPattern} ".ToLower());
            int searchInx5 = (caseSensitivity) ? subs.IndexOf($@".{SearchPattern} ") : subs.ToLower().IndexOf($@".{SearchPattern} ".ToLower());
            int searchInx6 = (caseSensitivity) ? subs.IndexOf($@",{SearchPattern},") : subs.ToLower().IndexOf($@",{SearchPattern},".ToLower());
            int searchInx7 = (caseSensitivity) ? subs.IndexOf($@".{SearchPattern}.") : subs.ToLower().IndexOf($@".{SearchPattern}.".ToLower());
            int searchInx8 = (caseSensitivity) ? subs.IndexOf($@",{SearchPattern}.") : subs.ToLower().IndexOf($@",{SearchPattern}.".ToLower());
            int searchInx9 = (caseSensitivity) ? subs.IndexOf($@".{SearchPattern},") : subs.ToLower().IndexOf($@".{SearchPattern},".ToLower());

            if (searchInx1 >= 0) inx.Add(searchInx1);
            if (searchInx2 >= 0) inx.Add(searchInx2);
            if (searchInx3 >= 0) inx.Add(searchInx3);
            if (searchInx4 >= 0) inx.Add(searchInx4);
            if (searchInx5 >= 0) inx.Add(searchInx5);
            if (searchInx6 >= 0) inx.Add(searchInx6);
            if (searchInx7 >= 0) inx.Add(searchInx7);
            if (searchInx8 >= 0) inx.Add(searchInx8);
            if (searchInx9 >= 0) inx.Add(searchInx9);

            int searchInx = -1;
            if (inx.Count > 0)
            {
                searchInx = subs.Length;
                foreach (int i in inx)
                {
                    if (i < searchInx) searchInx = i;
                }
            }
            return searchInx;
        }

        public List<SearchListItem> FindRange()
        {
            searchList = new List<SearchListItem>();
            if (SearchPattern.Length <= 0) return searchList;
            bookmarkList = FindBookmarks();

            searchListInx = -1;
            while (searchInxOld < fctInfo.Text.Length)
            {
                if (searchInxOld == 0)
                {
                    string subs = fctInfo.Text.Substring(searchInxOld);

                    if (wholeWord)
                    {
                        searchInx = GetLowestInx(subs);
                    }
                    else
                    {
                        searchInx = (caseSensitivity) ? subs.IndexOf(SearchPattern) : subs.ToLower().IndexOf(SearchPattern.ToLower());
                    }

                    if (searchInx < 0) return searchList;

                    searchInxOld = (wholeWord) ? searchInx + searchInxOld + 1 : searchInx + searchInxOld;
                    SearchListItem si = new SearchListItem()
                    {
                        pos = searchInxOld,
                        length = SearchPattern.Length,
                        text = $@"Item {searchList.Count + 1}"
                    };
                    searchList.Add(si);
                }
                else
                {
                    string subs = fctInfo.Text.Substring(searchInxOld + 1);

                    if (wholeWord)
                    {
                        //searchInx = (caseSensitivity) ? subs.IndexOf($@" {SearchPattern} ") : subs.ToLower().IndexOf($@" {SearchPattern} ".ToLower());
                        searchInx = GetLowestInx(subs);
                    }
                    else
                    {
                        searchInx = (caseSensitivity) ? subs.IndexOf(SearchPattern) : subs.ToLower().IndexOf(SearchPattern.ToLower());
                    }
                    if (searchInx < 0) return searchList;

                    searchInxOld = (wholeWord) ? searchInx + searchInxOld + 2 : searchInx + searchInxOld + 1;
                    SearchListItem si = new SearchListItem()
                    {
                        pos = searchInxOld,
                        length = SearchPattern.Length,
                        text = $@"Item {searchList.Count + 1}"
                    };
                    searchList.Add(si);
                }
            }
            return searchList;
        }

        public List<int> FindBookmarks()
        {

            List<int> searchList = new List<int>();
            if (SearchPattern.Length <= 0) return searchList;
            searchListInx = -1;
            for (int i = 0; i < fctInfo.LinesCount; i++)
            {
                string line = fctInfo.Lines[i];
                bool found = false;
                if (wholeWord)
                {
                    found = (CaseSensitivity)
                        ? line.Contains($@" {SearchPattern} ")
                        || line.Contains($@" {SearchPattern},")
                        || line.Contains($@" {SearchPattern}.")
                        || line.Contains($@",{SearchPattern} ")
                        || line.Contains($@".{SearchPattern} ")
                        || line.Contains($@",{SearchPattern},")
                        || line.Contains($@".{SearchPattern}.")
                        || line.Contains($@",{SearchPattern}.")
                        || line.Contains($@".{SearchPattern},")

                        : line.ToLower().Contains(SearchPattern.ToLower())
                        || line.ToLower().Contains($@" {SearchPattern},".ToLower())
                        || line.ToLower().Contains($@" {SearchPattern}.".ToLower())
                        || line.ToLower().Contains($@",{SearchPattern} ".ToLower())
                        || line.ToLower().Contains($@".{SearchPattern} ".ToLower())
                        || line.ToLower().Contains($@",{SearchPattern},".ToLower())
                        || line.ToLower().Contains($@".{SearchPattern}.".ToLower())
                        || line.ToLower().Contains($@".{SearchPattern},".ToLower())
                        || line.ToLower().Contains($@",{SearchPattern}.".ToLower());
                }
                else
                {
                    found = (CaseSensitivity) ? line.Contains(SearchPattern) : line.ToLower().Contains(SearchPattern.ToLower());
                }
                if (found)
                {
                    searchList.Add(i);
                }
            }
            return searchList;
        }

        public void GoToNext()
        {
            if (SearchPattern.Length <= 0) return;
            if (searchList?.Count <= 0) return;
            if (doNewSearch)
            {
                GoToFirst();
                doNewSearch = false;
            }
            else
            {
                if (searchListInx >= searchList.Count - 1) return;
                SearchListItem n = searchList[++searchListInx];
                fctInfo.SelectionStart = n.pos;
                fctInfo.SelectionLength = n.length;
                fctInfo.DoSelectionVisible();
                actItemInx++;
            }
        }

        public void GoToPrev()
        {
            if (SearchPattern.Length <= 0) return;
            if (searchList?.Count <= 0) return;
            if (doNewSearch)
            {
                GoToFirst();
                doNewSearch = false;
            }
            else
            {
                if (searchListInx <= 0) return;
                SearchListItem n = searchList[--searchListInx];
                fctInfo.SelectionStart = n.pos;
                fctInfo.SelectionLength = n.length;
                fctInfo.DoSelectionVisible();
                actItemInx--;
            }
        }

        public void GoToFirst()
        {
            actItemInx = -1;
            if (SearchPattern.Length <= 0) return;
            if ((searchList?.Count <= 0) && (!doNewSearch)) return;
            fctInfo.SelectionStart = 0;
            searchInxOld = 0;
            searchListInx = -1;
            if (doNewSearch)
            {
                searchList = FindRange();
                doNewSearch = false;
                BookmarkAll();
            }

            GoToNext();
        }

        public void GoToLast()
        {
            actItemInx = -1;
            if (SearchPattern.Length <= 0) return;
            if ((searchList?.Count <= 0) && (!doNewSearch)) return;
            fctInfo.SelectionStart = 0;
            searchInxOld = 0;
            searchListInx = -1;
            if (doNewSearch)
            {
                searchList = FindRange();
                doNewSearch = false;
                BookmarkAll();
            }
            searchListInx = searchList.Count - 1;

            SearchListItem n = searchList[searchListInx];
            fctInfo.SelectionStart = n.pos;
            fctInfo.SelectionLength = n.length;
            fctInfo.DoSelectionVisible();
            actItemInx = searchList.Count - 1;



        }
    }
}
