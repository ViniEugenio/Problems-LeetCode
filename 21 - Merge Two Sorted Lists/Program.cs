static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{

    if (list1 == null)
    {
        return list2;
    }

    if (list2 == null)
    {
        return list1;
    }

    if (list1.val <= list2.val)
    {

        list1.next = MergeTwoLists(list1.next, list2);
        return list1;

    }

    list2.next = MergeTwoLists(list1, list2.next);
    return list2;

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


var terceiroNoPrimeiraLista = new ListNode(4);
var segundoNoPrimeiraLista = new ListNode(2, terceiroNoPrimeiraLista);
var primeiroNoPrimeiraLista = new ListNode(1, segundoNoPrimeiraLista);

Console.WriteLine("Números da primeira lista:");
MostrarNumeros(primeiroNoPrimeiraLista);

Console.WriteLine();

var terceiroNoSegundaLista = new ListNode(4);
var segundoNoSegundaLista = new ListNode(3, terceiroNoSegundaLista);
var primeiroNoSegundaLista = new ListNode(1, segundoNoSegundaLista);

Console.WriteLine("Números da segunda lista:");
MostrarNumeros(primeiroNoSegundaLista);

Console.WriteLine();
Console.WriteLine("Números das listas ordenados:");
var retorno = MergeTwoLists(primeiroNoPrimeiraLista, primeiroNoSegundaLista);

MostrarNumeros(retorno);

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
