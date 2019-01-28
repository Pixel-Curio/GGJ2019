using System;
using Microsoft.Mixer;
using UnityEngine;
using Zenject;

namespace PixelCurio.GGJ2019
{
    public class MixerManager : IInitializable, ITickable, IDisposable
    {
        [Inject] private readonly Arrow _arrow;

        private int _count;
        private Vector2 _combinedPosition;

        private float _lastUpdate;
        private float _updateRate = 1;

        public void Initialize()
        {
            MixerInteractive.OnInteractiveCoordinatesChangedEvent += MouseMoved;
            MixerInteractive.GoInteractive();
            Debug.Log("Going live!");
        }

        private void MouseMoved(object sender, InteractiveCoordinatesChangedEventArgs e)
        {
            string viewName = e.Participant.UserName;
            _combinedPosition.x += e.Position.x;
            _combinedPosition.y += e.Position.y;
            _count++;
        }

        public void Tick()
        {
            if(Time.time - _lastUpdate > _updateRate)
            {
                _lastUpdate = Time.time;
                if (_count < 1) return;

                Vector3 position = _combinedPosition / _count;
                position.x += 15;
                position.y -= 30;

                _arrow.SetPosition(position);
                _combinedPosition = Vector3.zero;
                _count = 0;
            }
        }

        public void Dispose()
        {
            MixerInteractive.OnInteractiveCoordinatesChangedEvent -= MouseMoved;
        }
    }
}
