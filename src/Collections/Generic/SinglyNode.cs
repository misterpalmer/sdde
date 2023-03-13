namespace Udub.Sdde.Collections.Generic;

public class SinglyNode<T> : ISinglyNode<T>
{
    public T? Data { get; set; }

    public SinglyNode()
    {
        
    }

    public SinglyNode(T input)
    {
        if (input is null) throw new ArgumentNullException($"{nameof(input)} must contain non-null value.");

        Data = input;
    }

    public ISinglyNode<T>? Next
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
}