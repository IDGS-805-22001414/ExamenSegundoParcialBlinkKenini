import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-principal',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './principal.html',
  styleUrl: './principal.css'
})
export class PrincipalComponent {
  productosMasVendidos = [
    {
      nombre: 'Born Pink',
      descripcion: 'Álbum icónico de BLACKPINK con múltiples éxitos.',
      precio: 750,
      imagenUrl: 'https://saranghae.cl/wp-content/uploads/2022/08/blackpink-born-pink-pink-ver.png'
    },
    {
      nombre: 'K23',
      descripcion: 'Último lanzamiento de Kenia OS, puro arte.',
      precio: 680,
      imagenUrl: 'https://m.media-amazon.com/images/I/71-WKjoQVfL._UF350,350_QL50_.jpg'
    },
    {
      nombre: 'The Album',
      descripcion: 'Un clásico de BLACKPINK con canciones inolvidables.',
      precio: 720,
      imagenUrl: 'https://m.media-amazon.com/images/I/61sXO+AGa1L._UF1000,1000_QL80_.jpg'
    },

    {
      nombre: 'Square Up',
      descripcion: 'Mini álbum de BLACKPINK con energía única.',
      precio: 599,
      imagenUrl: 'https://choicemusicla.com/cdn/shop/products/o8FKY0t.jpg?v=1528841301'
    }
  ];
}
