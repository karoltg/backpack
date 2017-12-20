using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plecak
{
    class Thief
    {
        public ListOfElements LOE;
        public Backpack BP = new Backpack();
        public int backpackSize { get; set; }
        private int backpackSpaceLeft { get; set; }

        #region dodatkowe zmienne nieużywane
        //public int weightMin { get; set; }
        //public int weightMax { get; set; }
        //public int priceMin { get; set; }
        //public int priceMax { get; set; }
        //public int numberOfElements { get; set; }
        #endregion


        public Thief() { }
        public Thief(ListOfElements list, int backpackSize)
        {
            LOE = list;
            this.backpackSize = backpackSize;
            backpackSpaceLeft = backpackSize;
        }

        #region najlepszy wybór
        /// <summary>
        /// najlepszy wybór jaki można zapakować do plecaka
        /// </summary>
        public void best_pick()
        {
            int[] backpackPrice = new int[backpackSize];
            for (int i = 0; i < backpackPrice.Length; i++)
            { backpackPrice[i] = 0; }

            int[] backpackBestPrice = new int[backpackSize];
            int currentPrice = 0;
            int positionWeight = 0;

            for (int j = 0; j < LOE.Count; j++)
            {
                positionWeight = 0;
                for (int i = 0; i < backpackSize; i++)
                {
                    positionWeight++;
                    currentPrice = backpackPrice[i];

                    

                }

            }

        }

        private int backpack_value(int [] backpackValue)
        {
            int value = 0;

            for(int i=0; i<backpackValue.Length; i++)
            {
                value += backpackValue[i];
            }

            return value;
        }

        #endregion


        #region plecak od najlżejszego
        ///<summary> algorytm zachłanny zwracający załadowany plecak przez elementy od najlżejszych </summary>
        public void n_element_min_weight()
        {
            LOE = this.bubblesort_min_weight(LOE);
            for(int i = 0; i < LOE.Count; i++)
            {
                while (backpack_space_left(LOE[i]) == true)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                }
                if (backpackSpaceLeft == 0)
                    break;
            }
        }

        /// <summary>
        /// algorytm zachłanny zwracałący załadowany plecak przez elementy od najlżejszych,
        /// odejmuje liczbę elmentów z lisy
        /// </summary>
        public void r_element_min_weight()
        {
            this.bubblesort_min_weight(LOE);
            for(int i = 0; i < LOE.Count; i++)
            {
                while(backpack_space_left(LOE[i]) == true && LOE[i].elementCount > 0)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                    LOE[i].elementCount--;
                }
                if (backpackSpaceLeft <= 0 || LOE[i].weight > backpackSpaceLeft)
                        break;
            }
        }
        #endregion

        #region plecak od najdroższego
        ///<summary>algorytm zachłanny po cenie max </summary>
        public void n_element_max_price()
        {
            LOE = this.bubblesort_max_price(LOE);
            for(int i = 0; i < LOE.Count; i++)
            {
                while(backpack_space_left(LOE[i]) == true)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                }
                if (backpackSpaceLeft <= 0)
                    break;
            }
        }

        /// <summary>
        /// algorytm zachłanny po cenie max,
        /// odejmuje elementy z listy
        /// </summary>
        public void r_element_max_price()
        {
            LOE = this.bubblesort_max_price(LOE);
            for (int i = 0; i < LOE.Count; i++)
            {
                while (backpack_space_left(LOE[i]) == true || LOE[i].elementCount > 0)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                    LOE[i].elementCount--;
                }
                if (backpackSpaceLeft <= 0)
                    break;
            }
        }
        #endregion

        #region plecak cena / waga
        ///a<summary>lgorytm zachłanny cena/waga </summary>
        public void n_element_price_weight()
        {
            this.bubblesort(LOE);
            for(int i = 0; i < LOE.Count; i++)
            {
                while(backpack_space_left(LOE[i]) == true)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                }
                if (backpackSpaceLeft <= 0)
                    break;
            }
        }
        
        public void r_element_price_weight()
        {
            this.bubblesort(LOE);
            for (int i = 0; i < LOE.Count; i++)
            {
                while (backpack_space_left(LOE[i]) == true || LOE[i].elementCount > 0)
                {
                    BP.Add(LOE[i]);
                    backpackSpaceLeft -= LOE[i].weight;
                    LOE[i].elementCount--;
                }
                if (backpackSpaceLeft <= 0)
                    break;
            }
        }
        
        #endregion

        ///<summary>sprawdzanie czy coś jeszcze do plecaka wejdzie, zwraca true jeżeli wejdzie </summary>
        private bool backpack_space_left(Element element)
        {
            if (backpackSpaceLeft >= element.weight)
            {
                return true;
            }
            return false;
        }
        #region sortowania
        //sortowanie listy po masie, od najmniejszej do największej
        public ListOfElements bubblesort_min_weight(ListOfElements list)
        {
            bool koniec = false;
            ListOfElements pivot = new ListOfElements();
            pivot.Add(new Element(0, 0));

            for(int i = 0; i < list.Count; i++)
            {
                koniec = true;
                for(int j = 1; j < list.Count; j++)
                {
                    if(list[j - 1].weight > list[j].weight)
                    {
                        pivot[0] = list[j - 1];

                        list[j - 1] = list[j];

                        list[j] = pivot[0];
                        koniec = false;
                    }
                }
                if (koniec == true)
                break;

            }
            return list;
        }

        //sortuje po cenie, od najdrożyszej do najtańszej
        public ListOfElements bubblesort_max_price(ListOfElements list)
        {
            bool koniec = false;
            ListOfElements pivot = new ListOfElements();
            pivot.Add(new Element(0, 0));

            for (int i = 0; i < list.Count; i++)
            {
                koniec = true;
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j - 1].price < list[j].price)
                    {
                        pivot[0] = list[j - 1];

                        list[j - 1] = list[j];

                        list[j] = pivot[0];
                        koniec = false;
                    }
                }
                if (koniec == true)
                    break;

            }
            return list;
        }

        //sortowanie elementów po cena / waga
        public void bubblesort(ListOfElements list)
        {
            
            bool koniec = false;
            ListOfElements pivot = new ListOfElements();
            pivot.Add(new Element(0, 0));

            for (int i = 0; i < list.Count; i++)
            {
                koniec = true;
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j - 1].price / list[j - 1].weight < list[j].price / list[j].weight)
                    {
                        pivot[0].price = list[j].price;
                        pivot[0].weight = list[j].weight;

                        list[j].price = list[j - 1].price;
                        list[j].weight = list[j - 1].weight;

                        list[j - 1].price = pivot[0].price;
                        list[j - 1].weight = pivot[0].weight;

                        koniec = false;
                    }
                }

                if (koniec == true)
                    break;
            }
                        
            LOE = list;
        }
        #endregion

    }
}
