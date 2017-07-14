﻿'use strict';

window.chatApp.controllers.ChatController = function ($routeParams, $timeout)
{
	var vm = this,
		chatRsn = $routeParams.chatRsn;

	vm.messages = [];
	vm.cardAnimationClass = '.card-animation';
	vm.ConversationName = "";

	function getMessages()
	{
		window.api.Conversations
			.GetMessages({ "conversationRsn": chatRsn })
			.done
			(
				function (result, textStatus, jqXHR)
				{
					var data = result.ResultData;
					vm.totalRecords = data.length;
					vm.messages = data;

					vm.ConversationName = data[0].ConversationName;

					$timeout(function ()
					{
						//Turn off animation since it won't keep up with filtering
						vm.cardAnimationClass = '';
					}, 1000);
				}
			)
			.fail
			(
				function (jqXHR, textStatus, errorThrown)
				{
					console.error(textStatus, errorThrown);
				}
			);
	}

	function init()
	{
		getMessages();
	}

	init();
};

define
(
	['Scripts/app'],
	function (app)
	{
		app.register.controller('ChatController', window.chatApp.controllers.ChatController);
	}
);