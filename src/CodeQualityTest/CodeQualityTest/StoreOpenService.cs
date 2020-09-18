using System;

namespace CodeQualityTest
{
    public class StoreOpenService
    {
        // Constructor and other methods omitted for brevity...

        public bool IsStoreOpen(string State, string StoreNumber, DateTime dateTime)
        {
            bool o = false;

            // Florida stores closed on New Years
            if (dateTime.DayOfYear == 1 && State != "Florida")
            {
                o = false;
                //return
            }

            if (State == "Florida" || (State == "California" && StoreNumber != "123"))
            {
                if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    o = false;
                }
            }

            if (State == "California")
            {
                if (StoreNumber == "123")
                {
                    o = (dateTime.Hour >= 11 && dateTime.Hour < 20); // open from 11AM - 8PM
                }

                if (dateTime.Hour >= 10)
                {
                    if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                    {
                        o = dateTime.Hour < 20;
                    }

                    o = dateTime.Hour < 18;
                }

                o = false;
            }

            if (StoreNumber == "97")
            {
                if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    o = (dateTime.Hour >= 12 && dateTime.Hour < 22);
                }

                if (dateTime.Hour >= 10)
                {
                    if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                    {
                        o = dateTime.Hour < 17;
                    }

                    if (dateTime.DayOfWeek == DayOfWeek.Friday)
                    {
                        o = dateTime.Hour < 22;
                    }

                    o = dateTime.Hour < 19;
                }

                o = false;
            }

            if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                o = (dateTime.Hour >= 12 && dateTime.Hour < 18);
            }

            if (dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                o = (dateTime.Hour >= 9 && dateTime.Hour < 21);
            }

            if (dateTime.Hour < 17)
            {
                if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
                {
                    o = dateTime.Hour >= 11;
                }

                o = (dateTime.Hour >= 9);
            }

            return o;
        }

        /// <summary>
        /// This method is a duplicate.
        /// </summary>
        /// <param name="State"></param>
        /// <param name="StoreNumber"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public bool IsStoreOpen2(string State, string StoreNumber, DateTime dateTime, int unusedParameter)
        {
            bool o = false;

            // Florida stores closed on New Years
            if (dateTime.DayOfYear == 1 && State != "Florida")
            {
                o = false;
                //return
            }

            if (State == "Florida" || (State == "California" && StoreNumber != "123"))
            {
                if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    o = false;
                }
            }

            //if (State == "California")
            //{
            //    if (StoreNumber == "123")
            //    {
            //        o = (dateTime.Hour >= 11 && dateTime.Hour < 20); // open from 11AM - 8PM
            //    }

            //    if (dateTime.Hour >= 10)
            //    {
            //        if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            //        {
            //            o = dateTime.Hour < 20;
            //        }

            //        o = dateTime.Hour < 18;
            //    }

            //    o = false;
            //}

            if (StoreNumber == "97")
            {
                if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    o = (dateTime.Hour >= 12 && dateTime.Hour < 22);
                }

                if (dateTime.Hour >= 10)
                {
                    if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                    {
                        o = dateTime.Hour < 17;
                    }

                    if (dateTime.DayOfWeek == DayOfWeek.Friday)
                    {
                        o = dateTime.Hour < 22;
                    }

                    o = dateTime.Hour < 19;
                }

                o = false;
            }

            if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                o = (dateTime.Hour >= 12 && dateTime.Hour < 18);
            }

            if (dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                o = (dateTime.Hour >= 9 && dateTime.Hour < 21);
            }

            if (dateTime.Hour < 17)
            {
                if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
                {
                    o = dateTime.Hour >= 11;
                }

                o = (dateTime.Hour >= 9);
            }

            return o;
        }
    }
}