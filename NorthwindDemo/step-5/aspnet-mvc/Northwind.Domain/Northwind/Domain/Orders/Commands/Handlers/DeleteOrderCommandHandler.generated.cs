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
using Cqrs.Commands;
using Cqrs.Domain;

namespace Northwind.Domain.Orders.Commands.Handlers
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public  partial class DeleteOrderCommandHandler
		
		: ICommandHandler<Cqrs.Authentication.ISingleSignOnToken, DeleteOrderCommand>
	{
		protected IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> UnitOfWork { get; private set; }


		public DeleteOrderCommandHandler(IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		#region Implementation of ICommandHandler<in DeleteOrderCommand>

		public void Handle(DeleteOrderCommand command)
		{
			Order item = null;
			OnDeleteOrder(command, ref item);
			if (item == null)
				item = UnitOfWork.Get<Order>(command.Rsn);
			item.DeleteOrder();
			OnDeletedOrder(command, item);
			OnCommit(command, item);
			UnitOfWork.Commit();
			OnCommited(command, item);
		}

		#endregion

		partial void OnDeleteOrder(DeleteOrderCommand command, ref Order item);

		partial void OnDeletedOrder(DeleteOrderCommand command, Order item);

		partial void OnCommit(DeleteOrderCommand command, Order item);

		partial void OnCommited(DeleteOrderCommand command, Order item);
	}
}
