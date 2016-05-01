﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using Northwind.Domain.Orders.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Entities;

namespace Northwind.Domain.Orders.Entities
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public  partial interface IOrderEntity : IEntity
	{
		[DataMember]
		int OrderId { get; set; }

		[DataMember]
		string CustomerId { get; set; }

		[DataMember]
		int? EmployeeId { get; set; }

		[DataMember]
		DateTime? OrderDate { get; set; }

		[DataMember]
		DateTime? RequiredDate { get; set; }

		[DataMember]
		DateTime? ShippedDate { get; set; }

		[DataMember]
		int? ShipViaId { get; set; }

		[DataMember]
		decimal? Freight { get; set; }

		[DataMember]
		string ShipName { get; set; }

		[DataMember]
		string ShipAddress { get; set; }

		[DataMember]
		string ShipCity { get; set; }

		[DataMember]
		string ShipRegion { get; set; }

		[DataMember]
		string ShipPostalCode { get; set; }

		[DataMember]
		string ShipCountry { get; set; }

		[DataMember]
		ProductAddedToOrder ProductAddedToOrder { get; set; }

	}
}
