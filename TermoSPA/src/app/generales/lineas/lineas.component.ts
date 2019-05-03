import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lineas',
  templateUrl: './lineas.component.html',
  styles: []
})
export class LineasComponent implements OnInit {
  settings: any;
  data: any[];
  constructor() {}

  ngOnInit() {
    this.configGrid();
  }

  configGrid() {
    this.settings = {
      columns: [
        {
          dataIndex: 'name',
          title: 'Nombre'
        },
        {
          dataIndex: 'age',
          title: 'Edad'
        },
        {
          dataIndex: 'species',
          title: 'Especie'
        },
        {
          dataIndex: 'occupation',
          title: 'Ocupacion'
        }
      ]
    };

    this.data = [
      {
        name: 'Alex',
        age: 27,
        species: 'Ninguna',
        occupation: 'Programador'
      }
    ];
  }
}
