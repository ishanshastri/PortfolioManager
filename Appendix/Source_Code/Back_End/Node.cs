namespace IA_Implementation_1
    {
    /// <summary>
    /// A Node (generic) of a linked list (can hold data of type T)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
        {
        /// <summary>
        /// Gets or sets the value (data) of the node
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the next node.
        /// </summary>
        /// <value>
        /// The next node in the linked list.
        /// </value>
        public Node<T> Next { get; set; }
        }
    }
