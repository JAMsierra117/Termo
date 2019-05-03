import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { PaginationModule } from 'ngx-bootstrap/pagination';


import { AppComponent } from './app.component';
import { SidebarComponent } from './shared/sidebar/sidebar.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { GridClientesComponent } from './generales/clientes/grid-clientes.component';
import { ProductosComponent } from './generales/productos/productos.component';
import { ImpuesosComponent } from './generales/impuesos/impuesos.component';
import { ZonasImpuestosComponent } from './generales/zonas-impuestos/zonas-impuestos.component';
import { FormaspagosComponent } from './generales/formaspagos/formaspagos.component';
import { LineasComponent } from './generales/lineas/lineas.component';
import { AppRoutingModule } from './app-routes.module';
import { TermoGridComponent } from './shared/grid/termo-grid/termo-grid.component';
import { TermoRowComponent } from './shared/grid/termo-row/termo-row.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    NavbarComponent,
    DashboardComponent,
    GridClientesComponent,
    ProductosComponent,
    ImpuesosComponent,
    ZonasImpuestosComponent,
    FormaspagosComponent,
    LineasComponent,
    TermoGridComponent,
    TermoRowComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PaginationModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
