import { Component, OnInit } from '@angular/core';
import { settingsGrid, dataGrid } from './clientes.config';

@Component({
  selector: 'app-clientes',
  templateUrl: './grid-clientes.component.html',
  styles: []
})
export class GridClientesComponent implements OnInit {

  settings: any;
  data: any[];
  constructor() {}

  ngOnInit() {
    this.configGrid();
  }

  configGrid() {
    this.settings = settingsGrid;
    this.data = dataGrid;
  }

}
