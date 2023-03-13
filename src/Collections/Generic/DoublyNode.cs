namespace Udub.Sdde.Collections.Generic;

public class DoublyNode<T> : IDoublyNode<T>
{
    public T Data { get; set; }
    public IDoublyNode<T>? Previous
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
    public IDoublyNode<T>? Next
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public DoublyNode(T input)
    {
        if (input is null) throw new ArgumentNullException($"{nameof(input)} must contain non-null value.");

        Data = input;
    }
}