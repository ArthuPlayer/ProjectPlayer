using Unity.Netcode;

using UnityEngine;

public class EntrarServidor : MonoBehaviour

{

    public void Entrar()

    {

        NetworkManager.Singleton.StartClient();

    }

}
