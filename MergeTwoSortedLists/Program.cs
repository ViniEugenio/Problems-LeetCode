

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{

    if (list1 == null)
    {
        return list2;
    }

    if (list2 == null)
    {
        return list1;
    }

    var node = new ListNode();

    while (list1 != null && list2 != null)
    {

        if (list1.val > list2.val)
        {
            node.next = new ListNode(list2.val, new ListNode(list1.val));
        }

        else
        {
            node.next = new ListNode(list1.val, new ListNode(list2.val));
        }

        list1 = list1.next;
        list2 = list2.next;

    }

    return node.next;

}

var lista1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var lista2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var listaOrdenada = MergeTwoLists(lista1, lista2);

while (listaOrdenada.next != null)
{

    Console.WriteLine(listaOrdenada.val);
    listaOrdenada = listaOrdenada.next;

}

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}