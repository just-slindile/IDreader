namespace ID;

public class Filter
{
    public List<ID> beforeYear(List<ID> ids, Int16 year)
    {
        List<ID> filtered = new List<ID> {};
        foreach (ID id in ids)
            if (id.getYear() < year)
                filtered.Add(id);
        return filtered;
    }

    public List<ID> afterYear(List<ID> ids, Int32 year)
    {
        List<ID> filtered = new List<ID> {};
        foreach (ID id in ids)
            if (id.getYear() > year)
                filtered.Add(id);
        return filtered;
    }
}