using Zenject;

namespace PixelCurio.GGJ2019
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MixerManager>().AsSingle().NonLazy();
        }
    }
}
