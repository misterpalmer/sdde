using System.Collections;

namespace Udub.Sdde.Collections.Generic;


public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
{
    private IDoublyNode<T> _current;

    public T Current => throw new NotImplementedException();
    object IEnumerator.Current => throw new NotImplementedException();

    public DoublyLinkedListEnumerator(ref IDoublyNode<T> input)
    {
        _current = input;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        // if (_current == null) yield return false;
        // _current = _current!.Next!;
        // yield return (_current != null);
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
