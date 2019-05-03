import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

declare var $: any;
declare function init_plugins();

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'TermoSPA';

  constructor(private router: Router) {
    this.router.events.subscribe((event: any) => {
     // console.log(event);
      $('.right_col').css('min-height', $(window).height());
    });
  }

  ngOnInit(): void {
    init_plugins();
  }
}
