import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BasketService } from 'src/app/basket/basket.service';
import { Basket, IBasketTotals } from '../models/basket';

@Component({
  selector: 'order-totals',
  templateUrl: './order-totals.component.html',
  styleUrls: ['./order-totals.component.css']
})
export class OrderTotalsComponent implements OnInit {
  basketTotal$:Observable<IBasketTotals>;
  basketTotal: IBasketTotals;

  constructor(private basketService:BasketService) { }

  ngOnInit(): void {
    this.basketTotal$ = this.basketService.basketTotal$;
    this.basketTotal$.subscribe((response) => {
      this.basketTotal = response;

    });
  }

}
