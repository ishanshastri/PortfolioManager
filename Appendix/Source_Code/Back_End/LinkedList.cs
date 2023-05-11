using System;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Represents a linked list that stores data of type <see cref="Position"/>
    /// </summary>
    public class PositionLinkedList
        {
        /// <summary>
        /// The head node
        /// </summary>
        public Node<Position> Head;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionLinkedList"/> class.
        /// </summary>
        public PositionLinkedList()
            {

            }

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <param name="pi">The position information.</param>
        /// <returns></returns>
        public Position GetPosition(PositionInfo pi)
            {
            //Start at root, and get position
            return this.getPosition(pi, this.Head);
            }

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <param name="pi">The position information.</param>
        /// <param name="current">The current node.</param>
        /// <returns></returns>
        private Position getPosition(PositionInfo pi, Node<Position> current)
            {
            //If the current node is null, then the whole list has been traversed without finding the node
            if (current == null)
                {
                return null;
                }

            //If the current node is correct, return its value (the position)
            if (current.Value.ID.Equals(pi.ID))
                {
                return current.Value;
                }

            //Proceed to next node
            return getPosition(pi, current.Next);
            }

        /// <summary>
        /// Removes the specified position.
        /// </summary>
        /// <param name="id">The position's id.</param>
        public void Remove(Guid id)
            {
            if(Head == null)
                {
                return;//Do not proceed if list is empty
                }

            //If the head is being removed, handle case (effectively replace head)
            if (Head.Value.ID.Equals(id))
                {
                this.Head = Head.Next;
                return;
                }

            //Otherwise proceed to standard remove procedure
            this.remove(id, this.Head);
            }

        /// <summary>
        /// Removes the specified position.
        /// </summary>
        /// <param name="id">The position's identifier.</param>
        /// <param name="current">The current node.</param>
        private void remove(Guid id, Node<Position> current)
            {
            if (current.Next == null)
                {
                return;//End of list reached
                }

            //If the next node is the one being sought, remove (redirect current's pointer)
            if (current.Next.Value.ID.Equals(id))
                {
                current.Next = current.Next.Next;
                return;
                }

            //If neither case, check next node
            remove(id, current.Next);
            }

        /// <summary>
        /// Adds the specified position to the linked list.
        /// </summary>
        /// <param name="p">The position.</param>
        public void Add(Position p)
            {
            //If root is null, initialize it as new value
            if(this.Head == null)
                {
                this.Head = new Node<Position>();
                Head.Value = p;
                return;
                }

            //If root exists, then traverse nodes until end and append the new node
            Node<Position> curr = this.Head;
            while(curr.Next != null)
                {
                curr = curr.Next;
                }

            //Generate and append new node
            Node<Position> newNode = new Node<Position>();
            newNode.Value = p;
            curr.Next = newNode;
            }
        }
    }
