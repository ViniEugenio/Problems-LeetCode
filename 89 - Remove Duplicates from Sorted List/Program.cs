
static ListNode DeleteDuplicates(ListNode head)
{

    if (head == null)
    {
        return head;
    }

    while (head.next != null && head.val == head.next.val)
    {
        head.next = head.next.next;
    }

    DeleteDuplicates(head.next);
    return head;

}

static void MostrarNumeros(ListNode? head)
{

    if (head?.val == null)
    {
        return;
    }

    Console.WriteLine(head.val);
    MostrarNumeros(head.next);

}

var quintoNo = new ListNode(3, null);
var quartoNo = new ListNode(3, quintoNo);
var terceiroNo = new ListNode(2, quartoNo);
var segundoNo = new ListNode(1, terceiroNo);
var primeiroNo = new ListNode(1, segundoNo);

Console.WriteLine("Números de entrada:");
MostrarNumeros(primeiroNo);

var numerosRemovendoDuplicacoes = DeleteDuplicates(primeiroNo);

Console.WriteLine();
Console.WriteLine("Números removendo duplicações:");
MostrarNumeros(numerosRemovendoDuplicacoes);

public class ListNode
{

    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

}

