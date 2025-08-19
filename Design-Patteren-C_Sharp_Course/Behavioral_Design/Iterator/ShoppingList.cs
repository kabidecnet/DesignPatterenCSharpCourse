namespace Design_Patteren_C_Sharp_Course.Behavioral_Design.Iterator
{
    internal class ShoppingList
    {
        // If I change the shopping type to int from string still this will work
        // because we are iterating over interface logic.
        List<string> _shoppingList = new List<string>();
        public void AddToCart(string product)
        {
            _shoppingList.Add(product);
        }
        public List<string> GetList()
        {
            return _shoppingList;
        }
        public IIterator<string> GetIterator()
        {
            return new ListIterator(this);
        }
        private class ListIterator : IIterator<string>
        {
            private readonly ShoppingList _shoppingList;
            private int _index;
            public ListIterator(ShoppingList shoppingList)
            {
                _shoppingList = shoppingList;
                _index = 0;
            }
            public string Current()
            {
                return _shoppingList._shoppingList[_index];
            }

            public bool HasNext()
            {
                return _shoppingList._shoppingList.Count > _index;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
