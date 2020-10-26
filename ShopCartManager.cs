using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Plutus
{
    class ShopCartManager
    {
        private List<ShopExpense> _sCartParts = new List<ShopExpense>();
        private int[] _stateCount= {0, 0, 0};
        public ShopCartManager(Cart cart)
        {
            var elemC = cart.GiveElementC();
            for(var i = 0; i < elemC; i++)
            {
                AddNewElem(cart.GiveElement(i));
            }
        }
        private void AddNewElem(Expense exp)
        {
            var newElem = new ShopExpense(exp);
            _stateCount[0] += 1;
            _sCartParts.Add(newElem);
        }

        public int GiveSCount(int index)
        {
            return _stateCount[index];
        }

        public void ChangeState(int index, int state)
        {
            var prevS = _sCartParts[index].State;
            _stateCount[prevS] -= 1;
            _stateCount[state] += 1;
            _sCartParts[index].State = state;
        }

        public void ChangeState(int index)
        {
            var prevS = _sCartParts[index].State;
            _stateCount[prevS] -= 1;
            var newstate = prevS == 1 ? 0 : 1;
            _stateCount[newstate] += 1;
            _sCartParts[index].State = newstate;
        }

        public string GiveStateIndex(int state)
        {
            var answer = "";
            for (var i = 0; i < _sCartParts.Count; i++)
            {
                if(_sCartParts[i].State == state)
                {
                    answer += i;
                    answer += "|";
                }
            }
            return answer;
        }
        public void Account(DataManager dm)
        {
            var i = 0;
            foreach (var expense in _sCartParts)
            {
                if (expense.State == 1)
                {
                    var charge = new Expense();
                    charge.Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    charge.Name = expense.Name;
                    charge.Price = expense.Price;
                    charge.Category = expense.Category;
                    dm.addExpense(charge);
                    ChangeState(i);
                    i++;
                }
            }
        }

    }
}
