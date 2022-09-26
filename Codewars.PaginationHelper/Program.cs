public class PagnationHelper<T>
{
    private IList<T> _tList;
    private int _itemsPerPage;

    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PagnationHelper(IList<T> collection, int itemsPerPage)
    {
        _tList = collection;
        _itemsPerPage = itemsPerPage;
    }
  
    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount => _tList.Count;
  
    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount => (int)Math.Ceiling(ItemCount / (double) _itemsPerPage);
  
    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0 || pageIndex >= PageCount) return -1;
        if (pageIndex == PageCount - 1) return ItemCount % _itemsPerPage;
        return _itemsPerPage;
    }
  
    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        if (itemIndex > ItemCount - 1 || itemIndex < 0)
            return -1;
        return (int)Math.Ceiling((itemIndex + 1) / (double)_itemsPerPage) - 1;
    }
}

public static class Program
{
    public static void Main()
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        var pagination = new PagnationHelper<int>(list, 2);

        Console.WriteLine(pagination.ItemCount);
        Console.WriteLine(pagination.PageCount);
        Console.WriteLine(pagination.PageIndex(0));
        Console.WriteLine(pagination.PageItemCount(1));
    }
}
