using System.Collections.Generic;
using System.Linq;

namespace UBImGui.Utils
{
    public class TwoWayDictionary<T1, T2>
    {
        Dictionary<T1, T2> _forwards = new Dictionary<T1, T2>();
        Dictionary<T2, T1> _backwards = new Dictionary<T2, T1>();

        public IReadOnlyDictionary<T1, T2> Forwards => _forwards;
        public IReadOnlyDictionary<T2, T1> Backwards => _backwards;

        public IEnumerable<T1> Set1 => Forwards.Keys;
        public IEnumerable<T2> Set2 => Backwards.Keys;


        public TwoWayDictionary()
        {
            _forwards = new Dictionary<T1, T2>();
            _backwards = new Dictionary<T2, T1>();
        }

        public TwoWayDictionary(int capacity)
        {
            _forwards = new Dictionary<T1, T2>(capacity);
            _backwards = new Dictionary<T2, T1>(capacity);
        }

        public TwoWayDictionary(Dictionary<T1, T2> initial)
        {
            _forwards = initial;
            _backwards = initial.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        }

        public TwoWayDictionary(Dictionary<T2, T1> initial)
        {
            _backwards = initial;
            _forwards = initial.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        }


        public T1 this[T2 index]
        {
            get => _backwards[index];
            set
            {
                if (_backwards.TryGetValue(index, out var removeThis))
                    _forwards.Remove(removeThis);

                _backwards[index] = value;
                _forwards[value] = index;
            }
        }

        public T2 this[T1 index]
        {
            get => _forwards[index];
            set
            {
                if (_forwards.TryGetValue(index, out var removeThis))
                    _backwards.Remove(removeThis);

                _forwards[index] = value;
                _backwards[value] = index;
            }
        }

        public int Count => _forwards.Count;

        public bool Contains(T1 item) => _forwards.ContainsKey(item);
        public bool Contains(T2 item) => _backwards.ContainsKey(item);

        public bool Remove(T1 item)
        {
            if (!Contains(item))
                return false;

            var t2 = _forwards[item];

            _backwards.Remove(t2);
            _forwards.Remove(item);

            return true;
        }

        public bool Remove(T2 item)
        {
            if (!Contains(item))
                return false;

            var t1 = _backwards[item];

            _forwards.Remove(t1);
            _backwards.Remove(item);

            return true;
        }

        public void Clear()
        {
            _forwards.Clear();
            _backwards.Clear();
        }
    }
}