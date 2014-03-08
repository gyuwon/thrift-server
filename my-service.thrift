struct Contact {
  1: required i32 id,
  2: required string firstName,
  3: required string lastName,
  4: required string email
}

service ContactsService {
  list<Contact> getContacts()
}