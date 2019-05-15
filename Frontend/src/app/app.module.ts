import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { MaterialNGModuleModule } from './material-ngmodule.module';
import { ContactsComponent } from './contacts/contacts.component';
import { CreateContactComponent } from './create-contact/create-contact.component';
import { ContactComponent } from './contact/contact.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactsComponent,
    CreateContactComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialNGModuleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
