import { NgModule } from '@angular/core';

import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { GridClientesComponent } from './generales/clientes/grid-clientes.component';
import { ProductosComponent } from './generales/productos/productos.component';
import { LineasComponent } from './generales/lineas/lineas.component';
import { ImpuesosComponent } from './generales/impuesos/impuesos.component';
import { ZonasImpuestosComponent } from './generales/zonas-impuestos/zonas-impuestos.component';
import { FormaspagosComponent } from './generales/formaspagos/formaspagos.component';



const routes: Routes = [
    { path: 'dashboard', component: DashboardComponent },
    { path: 'clientes', component: GridClientesComponent },
    { path: 'productos', component: ProductosComponent },
    { path: 'lineas', component: LineasComponent },
    { path: 'impuestos', component: ImpuesosComponent },
    { path: 'zonasImpuestos', component: ZonasImpuestosComponent},
    { path: 'formasPagos', component: FormaspagosComponent },
    { path: '',
      redirectTo: '/dashboard',
      pathMatch: 'full'
    },
    { path: '**', component: DashboardComponent }
  ];

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [
        RouterModule
    ]
  })
  export class AppRoutingModule {}
