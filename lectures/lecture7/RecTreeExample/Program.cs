string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2,", "1", "3" };

void InOrderTravelsal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTravelsal(left);
        System.Console.WriteLine(tree[pos]);
        if(right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTravelsal(right);
    }
}