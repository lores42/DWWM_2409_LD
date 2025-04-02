export const getPays = async () => {
    try {
        const response = await fetch("https://raw.githubusercontent.com/ARFP/DWWM_2409/refs/heads/develop/02%20-%20webfront/JS/DemoPays/data/collectionPays.json");
        if (!response.ok) {
            throw new Error("problème durant le chargement du fichier !");
        }
        const data = await response.json()
        return data
    } catch (error) {
        console.log(error);
    }
};