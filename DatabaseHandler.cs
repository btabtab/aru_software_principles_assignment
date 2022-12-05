﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aru_software_eng_UI
{
	public class DatabaseHandler
	{

		/**/
		protected DatabaseWrapper database_wrapper;
		
		/* This is a blank entry that can be grabbed for testing sake
		while the database controller is being worked on. */
		
		protected DatabaseHandler()
		{
			database_wrapper = DatabaseWrapper.getDatabaseWrapperInstance();
		}

		/**/
		static DatabaseHandler singleton_instance;

		/**/
		static public DatabaseHandler getInstance()
        {
			if(singleton_instance == null)
            {
				singleton_instance = new DatabaseHandler();
			}
			return singleton_instance;

		}

		/**/
		public void deleteLoginRowX(int target_row)
        {
			database_wrapper.deleteRowX(DatabaseWrapper.LoginEntries, target_row);
		}

		/**/
		public void deleteInvestmentIdeaRowX(int target_row)
        {
			database_wrapper.deleteRowX(DatabaseWrapper.InvestmentIdeas, target_row);
		}

		/**/
		public int getRowCount(string table)
        {
			return database_wrapper.getRowCount(table);
		}

		/**/
		public int getHighestID(string target_table)
        {
			return database_wrapper.getHighestIDNumber(target_table, "UserID");
        }
	}
}