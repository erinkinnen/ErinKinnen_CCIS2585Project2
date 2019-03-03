﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ErinKinnen_CCIS2585Project2
{
    class clsDatabase
    {
        //***********************************************************
        //**  Procedure:  AcquireConnection()
        //**    Opens a connection using the default database
        //***********************************************************
        private static SqlConnection AcquireConnection()
        {
            return AcquireConnection("Payroll");
        }

        //***********************************************************
        //**  Procedure:  AcquireConnection()
        //**  Description:
        //**    Opens a connection using the specified connection
        //**  NOTE: Overloaded class to allow SQL connection creation
        //**        by external calls.
        //***********************************************************
        public static SqlConnection AcquireConnection(String strConnName)
        {
            SqlConnection cnSQL = null;
            Boolean blnErrorOccurred = false;

            //** Verify parameter
            if (strConnName.Trim().Length < 1)
            {
                blnErrorOccurred = true;
            }
            else if (ConfigurationManager.ConnectionStrings[strConnName] == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings[strConnName].ToString();

                try
                {
                    cnSQL.Open();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return cnSQL;
            }
        }

        //***********************************************************
        //**  Procedure:  GetEmployees()
        //**    Retrieves all employees from the database
        //***********************************************************
        public static DataSet GetEmployees()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                //** Build command to execute stored procedure
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetAllEmployees";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();

                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //***********************************************************
        //**  Procedure:  GetEmployeeNames()
        //**    Retrieves employee name and id from Employee table 
        //***********************************************************
        public static DataSet GetEmployeeNames()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                //** Build command to execute stored procedure
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetEmployeeNames";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();

                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //***********************************************************
        //**  Procedure:  GetEmployeePayrate()
        //**    Retrieves payrate for specified employee
        //***********************************************************
        public static Decimal GetEmployeePayrate(Int32 intEmpID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Boolean blnErrorOccurred = false;
            Decimal decPay = 0m;
            Int32 intRetCode;

            //** Verify parameter exists
            if (intEmpID < 1)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cnSQL = AcquireConnection();
                if (cnSQL == null)
                {
                    blnErrorOccurred = true;
                }
                else
                {
                    //** Build command to execute stored procedure
                    cmdSQL = new SqlCommand();
                    cmdSQL.Connection = cnSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "GetPayrateByID";

                    cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                    cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                    cmdSQL.Parameters.Add(new SqlParameter("@PayRate", SqlDbType.SmallMoney));
                    cmdSQL.Parameters["@PayRate"].Direction = ParameterDirection.Output;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                    try
                    {
                        intRetCode = cmdSQL.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        blnErrorOccurred = true;
                    }
                    finally
                    {
                        cnSQL.Close();
                        cnSQL.Dispose();
                    }

                    if (!blnErrorOccurred)
                    {
                        if (cmdSQL.Parameters["@PayRate"].Value == DBNull.Value)
                        {
                            blnErrorOccurred = true;
                        }
                        else
                        {
                            decPay = Convert.ToDecimal(cmdSQL.Parameters["@PayRate"].Value);
                        }
                    }
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return -1.0m;
            }
            else
            {
                return decPay;
            }
        }

        //***********************************************************
        //**  Procedure:  GetEmployeePayroll()
        //**    Retrieves payroll records for specified employee
        //***********************************************************
        public static DataSet GetEmployeePayroll(Int32 intEmpID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            //** Verify parameter exists
            if (intEmpID < 1)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cnSQL = AcquireConnection();
                if (cnSQL == null)
                {
                    blnErrorOccurred = true;
                }
                else
                {
                    //** Build command to execute stored procedure
                    cmdSQL = new SqlCommand();
                    cmdSQL.Connection = cnSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "GetPayrollByEmployee";

                    cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                    cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                    dsSQL = new DataSet();

                    try
                    {
                        daSQL = new SqlDataAdapter(cmdSQL);
                        daSQL.Fill(dsSQL);
                        daSQL.Dispose();
                    }
                    catch (Exception ex)
                    {
                        blnErrorOccurred = true;
                        dsSQL.Dispose();
                    }
                    finally
                    {
                        cmdSQL.Parameters.Clear();
                        cmdSQL.Dispose();
                        cnSQL.Close();
                        cnSQL.Dispose();
                    }
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //*******************************************************
        //** Method: Exit()
        //** Prompts message box for user to verify that
        //** they want to close the app
        //*******************************************************
        public void Exit()
        {
            DialogResult dlgResult;

            dlgResult = MessageBox.Show("Are sure you want to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlgResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }
    }
}

