var thrift = require('thrift')
  , ContactsService = require('./gen-nodejs/ContactsService')
  , serviceTypes = require('./gen-nodejs/my-service_types.js')
  , Contact = serviceTypes.Contact;

var contacts = [
  new Contact({ id: 1, firstName: 'Tony', lastName: 'Stark', email: 'ironman@avengers.com' }),
  new Contact({ id: 2, firstName: 'Bruce', lastName: 'Banner',  email: 'hulk@avengers.com' }),
  new Contact({ id: 3, firstName: 'Thor', lastName: 'Odinson', email: 'thor@avengers.com' })
];

var server = thrift.createServer(ContactsService, {
  getContacts: function (result) {
    result(null, contacts);
  }
});

server.listen(process.env.PORT || 3000);
