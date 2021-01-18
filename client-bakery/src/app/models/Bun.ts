export enum BunType {
  /*Батон*/
  Loaf = 0,
  /*Багет*/
  Baguette = 1,
  /*Круассан*/
  Croissant = 2,
  /*Сметанник*/
  SourCream = 3,
  /*Крендель*/
  Pretzel = 4
}

export enum BunStatus {
  /*в продаже*/
  OnSell = 0,
  /*продано*/
  Sold = 1,
  /*удалено из продажи*/
  Wasted = 2,
}

/* булочка */
export class Bun {
  id: number;
  startPrice: number;
  lastPrice: number;
  creationDate: Date;
  expTime: number;
  sellTime: number;
  bunType: BunType;
  bunStatus: BunStatus;
  lastPriceUpdate: Date;
  hoursToNextPrice: number;
  nextPrice: number;

  }

