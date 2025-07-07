import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ProductoService, Producto } from '../../services/producto';

@Component({
  selector: 'app-productos',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './productos.html',
  styleUrl: './productos.css'
})
export class ProductosComponent implements OnInit {
  productos: Producto[] = [];
  productosFiltrados: Producto[] = [];
  categorias: string[] = [];
  busqueda: string = '';

  constructor(private productoService: ProductoService) {}

  ngOnInit(): void {
    this.productoService.getProductos().subscribe({
      next: data => {
        this.productos = data;
        this.productosFiltrados = data;
        this.categorias = [...new Set(data.map(p => p.categoria.nombre))];
      },
      error: err => console.error(err)
    });
  }

  filtrarProductos(): void {
    const texto = this.busqueda.toLowerCase();
    this.productosFiltrados = this.productos.filter(p =>
      p.nombre.toLowerCase().includes(texto)
    );
  }

  filtrarPorCategoria(cat: string): void {
    this.productosFiltrados = this.productos.filter(p =>
      p.categoria.nombre === cat
    );
  }

  resetFiltros(): void {
    this.busqueda = '';
    this.productosFiltrados = [...this.productos];
  }
}
