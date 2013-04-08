function PersonsProxy(apiAddress) { 
   BaseProxy.call(this, apiAddress, 'Persons'); 
} 

inheritPrototype(PersonsProxy, BaseProxy);

PersonsProxy.prototype.GetAll = function (callback, context, carryover) { 
   this.ExecuteRequest('GET', 'GetAll', null, callback, context, carryover); 
}; 

PersonsProxy.prototype.GetMen = function (callback, context, carryover) { 
   this.ExecuteRequest('GET', 'GetMen', null, callback, context, carryover); 
}; 

PersonsProxy.prototype.GetLadies = function (callback, context, carryover) { 
   this.ExecuteRequest('GET', 'GetWomen', null, callback, context, carryover); 
}; 

PersonsProxy.prototype.Save = function (request, callback, context, carryover) { 
   this.ExecuteRequest('POST', 'Save', request, callback, context, carryover); 
}; 

PersonsProxy.prototype.Get = function (request, callback, context, carryover) { 
   this.ExecuteRequest('GET', 'Get', request, callback, context, carryover); 
}; 

