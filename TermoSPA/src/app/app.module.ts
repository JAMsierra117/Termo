import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { SidebarComponent } from './shared/sidebar/sidebar.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ClientesComponent } from './generales/clientes/clientes.component';
import { ProductosComponent } from './generales/productos/productos.component';
import { ImpuesosComponent } from './generales/impuesos/impuesos.component';
import { ZonasImpuestosComponent } from './generales/zonas-impuestos/zonas-impuestos.component';
import { FormaspagosComponent } from './generales/formaspagos/formaspagos.component';
import { LineasComponent } from './generales/lineas/lineas.component';
import { AppRoutingModule } from './app-routes.module';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    NavbarComponent,
    DashboardComponent,
    ClientesComponent,
    ProductosComponent,
    ImpuesosComponent,
    ZonasImpuestosComponent,
    FormaspagosComponent,
    LineasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
