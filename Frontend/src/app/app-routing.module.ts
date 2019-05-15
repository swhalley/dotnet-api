import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContactsComponent } from './contacts/contacts.component';
import { CreateContactComponent } from './create-contact/create-contact.component';
import { ContactComponent } from './contact/contact.component';

const routes: Routes = [
  { path: "contacts", component: ContactsComponent },
  { path: "new", component: CreateContactComponent },
  { path: "contact/:id", component: ContactComponent },
  { path: "", redirectTo: "contacts", pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
