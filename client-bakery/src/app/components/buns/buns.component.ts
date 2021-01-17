import { Component, OnInit } from '@angular/core';
import {BunService} from '../../services/buns.service';
import {Bun, BunType} from '../../models/Bun';

@Component({
  selector: 'app-buns',
  templateUrl: './buns.component.html',
  styleUrls: ['./buns.component.css']
})
export class BunsComponent implements OnInit {
  buns: Bun [] ;
  constructor(private bunService: BunService) { }

  ngOnInit() {

    this.getListItems();

  }
  getListItems(): void {
    this.bunService.getListItems()
      .subscribe(listItems =>  {this.buns = listItems; });
  }
  getBunName(t: number): string {
    return BunType[t];
  }

}
