﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_ApiPractice2.Models
{
	public class EF_Models
	{
		public class Rootobject
		{
			public Meta meta { get; set; }
			public List<Reports> results { get; set; }
		}
		public class Meta
		{
			public string disclaimer { get; set; }
			public string terms { get; set; }
			public string license { get; set; }
			public string last_updated { get; set; }
			public Results results { get; set; }
		}
		public class Results
		{
			public int skip { get; set; }
			public int limit { get; set; }
			public int total { get; set; }
		}

		public class Reports
		{
			public string country { get; set; }
			public string city { get; set; }
			public string reason_for_recall { get; set; }
			public string address_1 { get; set; }
			public string address_2 { get; set; }
			public string code_info { get; set; }
			public string product_quantity { get; set; }
			public string center_classification_date { get; set; }
			public string distribution_pattern { get; set; }
			public string state { get; set; }
			public string product_description { get; set; }
			public string report_date { get; set; }
			public string classification { get; set; }
			//[NotMapped]
			//public string openfda { get; set; }
			// This is a comment just for testing. By Mandeep.
			[Key]
			public string recall_number { get; set; }


			public string recalling_firm { get; set; }
			public string initial_firm_notification { get; set; }
			public string event_id { get; set; }
			public string product_type { get; set; }
			public string termination_date { get; set; }
			[NotMapped]
			public object more_code_info { get; set; }
			public string recall_initiation_date { get; set; }
			public string postal_code { get; set; }
			public string voluntary_mandated { get; set; }
			public string status { get; set; }
		}
		
		
	}
}



