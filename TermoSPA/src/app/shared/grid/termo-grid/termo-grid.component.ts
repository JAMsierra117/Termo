import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-termo-grid',
  templateUrl: './termo-grid.component.html',
  styleUrls: ['./termo-grid.component.css']
})
export class TermoGridComponent implements OnInit {

  @Input() settings: any;
  @Input() data: any[];
  constructor() { }

  ngOnInit() {
  }

  nuevo() {
    console.log('nuevo');
  }
  editar() {
    console.log('editar');
  }
  eliminar() {
    console.log('eliminar');
  }

}
