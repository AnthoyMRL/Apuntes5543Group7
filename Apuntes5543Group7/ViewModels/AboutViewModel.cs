using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes5543Group7.ViewModels
{
    public class AboutViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Member> _teamMembers;

        public ObservableCollection<Member> TeamMembers
        {
            get => _teamMembers;
            set
            {
                if (_teamMembers != value)
                {
                    _teamMembers = value;
                    OnPropertyChanged();
                }
            }
        }

        public AboutViewModel()
        {
            LoadTeamMembers();
        }

        private void LoadTeamMembers()
        {

            TeamMembers = new ObservableCollection<Member>
            {

                new Member
                {
                    Nombre = "Anthony Morales",
                    Edad = 22,
                    DeporteFav = "Futbol",
                    Photo = "anthony.jpg",
                    Rol = "Desarrollador Full Stack",
                    Descripcion = "Siempre busca soluciones creativas y funcionales.",
                    SportIcon = "⚽"
                },
                new Member
                {
                    Nombre = "Roberto Manosalvas",
                    Edad = 23,
                    DeporteFav = "Futbol",
                    Photo = "roberto.jpg",
                    Rol = "Arquitecto de Software y Líder Técnico",
                    Descripcion = "Experto en estructuras de sistemas y diseño de APIs. Prefiere la lógica del código al deporte, aunque valora el enfoque y la disciplina.",
                    SportIcon = "⚽"
                },
                new Member
                {
                    Nombre = "Thais Rojas",
                    Edad = 24,
                    DeporteFav = "Basquet",
                    Photo = "thais.jpg",
                    Rol = "Diseñadora de Interfaces y Frontend",
                    Descripcion = "Apasionada por la estética visual y la interacción del usuario. Su energía y enfoque en equipo provienen de su amor por el baloncesto.",
                    SportIcon = "🏀"
                }
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
