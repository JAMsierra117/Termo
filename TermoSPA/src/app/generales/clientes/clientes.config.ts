export const settingsGrid = {
    columns: [
      {
        dataIndex: 'id_Cliente',
        title: '#',
        styleHeader: {width: '50px',
                      'text-align': 'center' },
        styleContent: {'text-align': 'center'}
      },
      {
        dataIndex: 'nombre',
        title: 'Nombre',
        template: (row: any) => {
          if (!row) { return ''; }
          return `<div>
                  ${row.nombre}<br>
                  ${row.apellidos}
                  </div>`;
        }
      },
      {
        dataIndex: 'direccion',
        title: 'Dirección',
        template: (row: any) => {
          if (!row) { return ''; }

          return `<div>
                    ${row.direccion}<br>
                    ${row.ciudad} ,${row.estado}
                  </div>`;
        }
      },
      {
        dataIndex: 'telefono',
        title: 'Teléfono'
      },
      {
        dataIndex: 'email',
        title: 'Email'
      },
      {
        dataIndex: 'activo',
        title: 'Estatus',
        styleHeader: {'text-align': 'center'},
        styleContent: {'text-align': 'center'},
        template: (row: any) => {
          if (!row) { return ''; }

          return `<span class="label label-success">Activo</span>`;

        }
      }
    ]
  };

export const dataGrid = [
    {
      id_Cliente: 1,
      nombre: 'Jesus Alejandro',
      apellidos: 'Rodriguez Morales',
      direccion: 'Dr. Pedro Lopez Camacho, Nuevo Cajeme',
      ciudad: 'Mazatlán',
      estado: 'Sinaloa',
      email: 'jam.rodriguez@gmail.com',
      telefono: '6672323842',
      activo: 'Si'
    },
    {
      id_Cliente: 2,
      nombre: 'Anael Guadalupe',
      apellidos: 'Lopez Nolasco',
      direccion: 'Vive por la pancho villa',
      ciudad: 'Mazatlán',
      estado: 'Sinaloa',
      email: 'aglopez@upc.tax',
      telefono: '6699040521',
      activo: 'Si'
    },
    {
      id_Cliente: 3,
      nombre: 'Maria Sonia',
      apellidos: 'Morales Morales',
      direccion: 'Calle No.3 #20115, FOVISSSTE Playa Azul',
      ciudad: 'Mazatlán',
      estado: 'Sinaloa',
      email: 'soniamorales@gmail.com',
      telefono: '6692845788',
      activo: 'Si'
    },
    {
      id_Cliente: 3,
      nombre: 'Maria Sonia',
      apellidos: 'Morales Morales',
      direccion: 'AV. 20 DE NOVIEMBRE NO 1320',
      ciudad: 'Mazatlán',
      estado: 'Sinaloa',
      email: 'soniamorales@gmail.com',
      telefono: '6692845788',
      activo: 'Si'
    },
    {
      id_Cliente: 3,
      nombre: 'Maria Sonia',
      apellidos: 'Morales Morales',
      direccion: 'CALLE ALDAMA NO.50',
      ciudad: 'Mazatlán',
      estado: 'Sinaloa',
      email: 'soniamorales@gmail.com',
      telefono: '6692845788',
      activo: 'Si'
    },
    {
      id_Cliente: 4,
      nombre: 'Maria Sonia',
      apellidos: 'Morales Morales',
      direccion: 'AV. 20 DE NOVIEMBRE ESQ. JUAREZ',
      ciudad: 'Mazatlán',
      estado: 'Sinaloa',
      email: 'soniamorales@gmail.com',
      telefono: '6692845788',
      activo: 'Si'
    }
  ];
