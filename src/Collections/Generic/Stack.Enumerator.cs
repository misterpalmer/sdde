using System.Collections;

namespace Udub.Sdde.Collections.Generic;

public struct Enumerator<T> : IEnumerator<T>
{
    public T Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}