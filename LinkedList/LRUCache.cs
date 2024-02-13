public class LRUCache {
    private readonly int _capacity;
    private readonly LinkedList<(int Key, int Value)> _linkedList = new();
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> _dict = new();
    
    public LRUCache(int capacity) {
       _capacity = capacity;
    }
    
    public int Get(int key) {
        
       // get item from dictionary and move item to the head of the linked list
        LinkedListNode<(int Key, int Value)> node;

        if (!_dict.TryGetValue(key, out node))
        {
            return -1;
        }
        else
        {            
            _linkedList.Remove(node);
            var newNode = _linkedList.AddFirst(node.Value);
            _dict[key] = newNode;
        }

        return node.Value.Value;
    }
    
    public void Put(int key, int value) {
       // if item key exists, update the item and move the item to the head of the linked list
       // if item does not exist 
          // if the capacity does not exceed the limit, just add a new item to the dictionaty and to the head of the ll
          // if the capacity exiceeds the limit, 
            // a) remove the item from the tail of the linked list
            // b) remove the item from dictionary
            // c) add new item to the dictionary and to the head of the ll

        LinkedListNode<(int Key, int Value)> node;

        if (_dict.TryGetValue(key, out node))
        {
            node.Value = (key, value);
            _linkedList.Remove(node);
            var newNode = _linkedList.AddFirst(node.Value);
            _dict[key] = newNode;
        }
        else
        {
            var newNode = _linkedList.AddFirst((key, value));
            _dict[key] = newNode;

            if (_dict.Count > _capacity)
            {
                _dict.Remove(_linkedList.Last.Value.Key);
                _linkedList.Remove(_linkedList.Last);                
            }
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
