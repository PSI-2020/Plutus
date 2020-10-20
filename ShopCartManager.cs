using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Plutus
{
    class ShopCartManager
    {
        private List<ShopExpense> sCartParts = new List<ShopExpense>();
        private int iCount = 0;
        private int[] stateCount= {0, 0, 0};
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
            iCount += 1;
            stateCount[0] += 1;
            sCartParts.Add(newElem);
        }

        public int GiveSCount(int index)
        {
            return stateCount[index];
        }

        public void ChangeState(int index, int state)
        {
            var prevS = sCartParts[index].State;
            stateCount[prevS] -= 1;
            stateCount[state] += 1;
            sCartParts[index].State = state;
        }

        public void ChangeState(int index)
        {
            var prevS = sCartParts[index].State;
            stateCount[prevS] -= 1;
            var newstate = prevS == 1 ? 0 : 1;
            stateCount[newstate] += 1;
            sCartParts[index].State = newstate;
        }

        public string GiveStateIndex(int state)
        {
            var answer = "";
            for (var i = 0; i < iCount; i++)
            {
                if(sCartParts[i].State == state)
                {
                    answer += i;
                    answer += "|";
                }
            }
            return answer;
        }
        
    }
}
