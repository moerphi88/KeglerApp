using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms.Helper
{
    class Program
    {
        public Program()
        {
            //string json = @"{""stations"":[{""Name"":""WXRT""},{""Name"":""WGN""}]}";

            // Foo foo = JsonConvert.DeserializeObject<Foo>(json);

            // foreach (StationDto dto in foo.Stations)
            // {
            //     System.Diagnostics.Debug.WriteLine(dto.Name);
            // }


            ObservableCollection<Kegler> oc = new ObservableCollection<Kegler>();
            ObservableCollection<Kegler> oc2 = new ObservableCollection<Kegler>();
            oc.Add(new Kegler { _imageUri = "bug_full.png", _vorname = "Katze 1", _nachname = "sjdksjd" });
            oc.Add(new Kegler { _imageUri = "bug_seven.png", _vorname = "Katze 2", _nachname = "sjdksjd" });
            oc.Add(new Kegler { _imageUri = "bug_six.png", _vorname = "Katze 3", _nachname = "sjdksjd" });
            oc.Add(new Kegler { _imageUri = "bug_six.png", _vorname = "Katze 4", _nachname = "sjdksjd" });

            string output = JsonConvert.SerializeObject(oc);

            System.Diagnostics.Debug.WriteLine(output);

            oc2 = JsonConvert.DeserializeObject<ObservableCollection<Kegler>>(output);

        }

        class StationDto
        {
            public string Name { get; set; }
        }

        

        class Foo
        {
            private ObservableCollection<StationDto> stations;

            [JsonProperty(PropertyName = "stations")]
            public ObservableCollection<StationDto> Stations
            {
                get { return this.stations; }
                set
                {
                    this.stations = value;
                    RaisePropertyChanged(() => Stations);
                }
            }

            private void RaisePropertyChanged(Func<ObservableCollection<StationDto>> coll)
            {
            }
        }
    }
}
