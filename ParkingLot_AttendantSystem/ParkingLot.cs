using System;
using System.Collections.Generic;

namespace ITS3100_ParkingApp3
{
    public class ParkingLot
    {
        static Customer[] CUSTOMERS = new Customer[1000];
        static string[] filter = new string[3] { "Name", "License Plate", "Parking Space" };

        #region Find Customer by 1:Name, 2: License Plate, 3: Parking Space

        public static string findCustomer(int option, string S)
        {
            S = "" + S.ToUpper().Trim();
            string result = "";
            List<Customer> customersList = new List<Customer>();

            //Find by Customer Name
            if (option == 1)
            {
                for (uint x = 0; x < CUSTOMERS.Length; x++)
                {
                    if ((CUSTOMERS[x] != null) && (CUSTOMERS[x].Name.ToUpper().Trim() == S))
                    {
                        result += getCustomer(x) + "\r\n\r\n";
                        customersList.Add(CUSTOMERS[x]);
                    };
                }
            };

            //Find by Customer License Plate
            if (option == 2)
            {
                for (uint x = 0; x < CUSTOMERS.Length; x++)
                {
                    if ((CUSTOMERS[x] != null) && (CUSTOMERS[x].Plate.ToUpper().Trim() == S))
                    {
                        result += getCustomer(x) + "\r\n\r\n";
                        customersList.Add(CUSTOMERS[x]);
                    };
                }
            }

            //Find Customer by Parking Space
            if (option == 3)
            {
                uint findParkingSpace;
                uint.TryParse(S, out findParkingSpace);

                for (uint x = 0; x < CUSTOMERS.Length; x++)
                {
                    if ((CUSTOMERS[x] != null) && (x + 1 == findParkingSpace))
                    {
                        result += getCustomer(x) + "\r\n\r\n";
                        customersList.Add(CUSTOMERS[x]);
                    };
                }
            }

            result = string.Format(
                "{0}s matching \"{1}\". \r\n\r\n Found {2} customers!" +
                "\r\n" + result + "\r\n\r\n"
                , filter[option - 1], S, customersList.Count);
            return result;
        }
        #endregion

        #region Remove Customer by 1:Name, 2: License Plate, 3: Parking Space
        public static string removeCustomer(uint option, string S)
        {
            uint removeX = 0;
            S = S.ToUpper().Trim();
            string result = "";
            List<Customer> customersList = new List<Customer>();

            //Find by Customer Name
            if (option == 1)
            {
                for (uint x = 0; x < CUSTOMERS.Length; x++)
                {
                    if ((CUSTOMERS[x] != null) && (CUSTOMERS[x].Name.ToUpper().Trim() == S))
                    {
                        removeX = x;
                        result += getCustomer(x) + "\r\n\r\n";
                        customersList.Add(CUSTOMERS[x]);
                    };
                }
            };

            //Find by Customer License Plate
            if (option == 2)
            {
                for (uint x = 0; x < CUSTOMERS.Length; x++)
                {
                    if ((CUSTOMERS[x] != null) && (CUSTOMERS[x].Plate.ToUpper().Trim() == S))
                    {
                        removeX = x;
                        result += getCustomer(x) + "\r\n\r\n";
                        customersList.Add(CUSTOMERS[x]);
                    };
                }
            }

            //Find Customer by Parking Space
            if (option == 3)
            {
                uint.TryParse(S, out removeX); //12

                if (removeX > 0 && removeX <= CUSTOMERS.Length && (CUSTOMERS[removeX - 1] != null))
                {
                    removeX = removeX - 1;
                    result = getCustomer(removeX);
                    customersList.Add(CUSTOMERS[removeX]);
                };
            }

            if (customersList.Count == 1)
            {
                result = string.Format("Removed Customer\r\n\r\n" + result);
                removeParking(removeX);
            }
            else if (customersList.Count > 1)
            {
                result = string.Format("Error! Multiple Matches.\r\n\r\n" + "Found {0} customers! \r\n\r\n" + result
                    , customersList.Count);
            }
            else
            {
                result = string.Format("{0}s matching \"{1}\".  \r\n\r\n No customers found!"
                    , filter[option - 1], S);
            }

            return result;
        }
        #endregion

        public static string findParking(string Name, string Plate)
        {
            string result = "No Parking Found!";

            for (uint x = 0; x < CUSTOMERS.Length; x++)
            {
                if (CUSTOMERS[x] == null)
                {
                    Customer C = new Customer(Name, Plate);
                    assignParking(C, x);
                    result = "Customer Parking Found \r\n" + getCustomer(x);
                    break;
                }
            }
            return result;
        }

        public static string getCustomer(uint x)
        {
            if(CUSTOMERS[x] != null)
            return string.Format(
                " Name: \t\t {0} \r\n License Plate: \t {1} \r\n Parking Space: \t {2} "
                , CUSTOMERS[x].Name, CUSTOMERS[x].Plate, (x + 1).ToString());
            return "No Customer Found!";
        }

        public static void assignParking(Customer C, uint X)
        {
            if (C != null && X < CUSTOMERS.Length) CUSTOMERS[X] = C;
        }

        public static void removeParking(uint X)
        {
            if (CUSTOMERS[X] != null) CUSTOMERS[X] = null;
        }

        public static string parkingLotStatus()
        {
            uint countCustomers = 0;
            string result = "";
            for (uint x = 0; x < CUSTOMERS.Length; x++)
            {
                if (CUSTOMERS[x] != null) countCustomers++;
            }
            
            result = string.Format(" {0} parking spaces available.", (CUSTOMERS.Length - countCustomers) );
            result += string.Format(" {0,3}% Capacity.", (double)countCustomers / CUSTOMERS.Length * 100);
            return result;
        }

        #region Testing

        public static string testParkingLotFull()
        {
            string result = "";
            
            // TEST: Full Parking Lot Assignment
            for (int x = 1; x <= 1000; x++)
            {
                try
                {
                    Customer testCustomer = new Customer("Customer " + x.ToString(), x.ToString());
                    assignParking(testCustomer, (uint)x-1);

                    //CUSTOMERS[x] = new Customer(x.ToString(), x.ToString());
                    //result = string.Format(result + "\r\n" + x.ToString() + "Success: Customer[x] Successful");
                }
                catch(IndexOutOfRangeException ex)
                {
                    result += string.Format(result + "\r\n {0} Error: {1}", x.ToString(), ex.Message);
                }
                catch (Exception ex)
                {
                    result += string.Format(result + "\r\n {0} Error: {1}", x.ToString(), ex.Message);
                }
            }
            result += "\r\n\r\n Parking Lot is Full";
            return result;
        }

        public static string testParkingLotEmpty()
        {
            string result = "Parking Lot is Empty";
            try { CUSTOMERS = new Customer[1000]; }
            catch (Exception ex)
            { result = string.Format("Error: {0}.", ex.Message); }
            return result;
        }

        public static string testParkingAssignment(){
            string result = "";
            // Test - assigning a Parking Space that is out of Range
            try
            {
                assignParking(new Customer("Park Overflow","Stuff It"), 1001);
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }
        #endregion
    }
}