using System.Collections;

namespace Udub.Sdde.Collections.Generic;


public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
{
    private ISinglyNode<T> _current;
    public SinglyLinkedListEnumerator(ref ISinglyNode<T> input)
    {
        _current = input;
    }

    public T Current => _current.Data!;

    object IEnumerator.Current => Current!;

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